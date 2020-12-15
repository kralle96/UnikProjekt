using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using application.Exceptions;

namespace application.Services.Machine_Learning
{
    //benytter den machine learning model der estimere antal år en givet ansøger vil blive boende i et givet lejemaal.

    //NOTE: Forklaring af filerne der bruges i python-scripted kan ses i den tilhørende notebook, hvor machine learning modellen
    //blev udviklet. Forklaring af hvordan den er blevet lavet og hvordan dataet er blevet behandlet står også der.
    public class NumberOfYearsPredictionPython : IPythonScript
    {
        public string Script { get; private set; } //scriptet der skal køres i python

        //næste seks properties er de parametre modellen er trænet på
        public string Sex { get; private set; }
        public int ResidentsInTheTenancy { get; private set; }
        public int NumberOfRoomsInTheTenancy { get; private set; }
        public string TypeOfTenancy { get; private set; }
        public string ResidentAgeGroup { get; private set; }
        public string LocationOfTenancy { get; private set; }
        //list til at holde parametre
        public List<object> Parameters { get; set; }
        //path til python.py filen der skal køres
        public string ScriptPath { get; set; } = @"..\application\Root\PythonScript\python\unik_machine_learning_script\test\test.py";
       
        public NumberOfYearsPredictionPython(string sex, int residentsInTheTenancy, int numberOfRoomsInTheTenancy,
            string typeOfTenancy, string locationOfTenancy, int residentAge)
        {
            //validere input til modellen
            ValidateInputForModel(sex, typeOfTenancy, locationOfTenancy, residentAge);
            ResidentsInTheTenancy = residentsInTheTenancy;
            NumberOfRoomsInTheTenancy = numberOfRoomsInTheTenancy;

            //tilføj til parametrer-listen
            Parameters = new List<object>();
            Parameters.Add(Sex);
            Parameters.Add(ResidentsInTheTenancy);
            Parameters.Add(NumberOfRoomsInTheTenancy);
            Parameters.Add(TypeOfTenancy);
            Parameters.Add(LocationOfTenancy);
            Parameters.Add(ResidentAgeGroup);

            //lav scriptet
            Script = SetScript();
        }
        public void ValidateInputForModel(string sex, string typeOfTenancy, string locationOfTenancy,
            int residentAge)
        {
            //valider og "oversæt" til den dataform modellen er trænet på.
            TranslateSex(sex);
            TranslateTypeOfTenancy(typeOfTenancy);
            TranslateLocationOfTenancy(locationOfTenancy);
            SplitResidentIntoAgeGroup(residentAge);
        }
        private void TranslateSex(string sex)
        {
            if (sex == "Mand")
            {
                Sex = "Male";
            }
            else if (sex == "Kvinde")
            {
                Sex = "Female";
            }
            else
            {
                throw new AttributeDoesNotExistInModelException($"Model has not been trained on this attribute");
            }
        }
        private void TranslateTypeOfTenancy(string typeOfTenancy)
        {
            if (typeOfTenancy == "Lejlighed")
            {
                TypeOfTenancy = "Apartment";
            }
            else
            {
                TypeOfTenancy = "Terraced_Chain_And_SemiDetachedHouses";

            }
        }
        private void TranslateLocationOfTenancy(string locationOfTenancy)
        {
            if (locationOfTenancy == "Nordjylland")
            {
                LocationOfTenancy = "The_Region_of_Northern_Jutland";
            }
            else if (locationOfTenancy == "Midtjylland")
            {
                LocationOfTenancy = "Central_Jutland_Region";
            }
            else if (locationOfTenancy == "Syddanmark")
            {
                LocationOfTenancy = "The_Region_of_Southern_Denmark";
            }
            else if (locationOfTenancy == "Sjælland")
            {
                LocationOfTenancy = "Region_Zealand";
            }
            else if (locationOfTenancy == "Hovedstaden")
            {
                LocationOfTenancy = "The_Capital_Region_of_Denmark";
            }
            else
            {
                throw new AttributeDoesNotExistInModelException($"Model has not been trained on this attribute");
            }
        }
        private void SplitResidentIntoAgeGroup(int residentAge)
        {

            if (residentAge >= 18 && residentAge <= 24)
            {
                ResidentAgeGroup = "18-24";
            }
            else if (residentAge >= 25 && residentAge <= 29)
            {
                ResidentAgeGroup = "25-29";
            }
            else if (residentAge >= 30 && residentAge <= 39)
            {
                ResidentAgeGroup = "30-39";
            }
            else if (residentAge >= 40 && residentAge <= 49)
            {
                ResidentAgeGroup = "40-49";
            }
            else if (residentAge >= 50 && residentAge <= 59)
            {
                ResidentAgeGroup = "50-59";
            }
            else if (residentAge >= 60 && residentAge <= 69)
            {
                ResidentAgeGroup = "60-69";
            }
            else if (residentAge >= 70 && residentAge <= 79)
            {
                ResidentAgeGroup = "70-79";
            }
            else if (residentAge >= 80 && residentAge <= 89)
            {
                ResidentAgeGroup = "80-89";
            }
            else if (residentAge >=90)
            {
                ResidentAgeGroup = "90_or_above";
            }
            else
            {
                throw new AttributeDoesNotExistInModelException($"Model has not been trained on this attribute");
            }
        }
        public string SetScript()
        {
            //scriptet der skal køres i python

            return @"import sys
import numpy as np
import pandas as pd
import pkg_resources
#pkg_resources.require('sklearn == 0.23.2')
import sklearn
import pickle
import os
from sklearn.preprocessing import RobustScaler
import joblib

#plot recieved data into dataframe
data = pd.DataFrame({
    'Sex' : [sys.argv[1]],
                     'ResidentsInTheTenancy' : [int(sys.argv[2])],
                     'NumberOfRoomsInTheTenancy' : [int(sys.argv[3])],
                     'TypeOfTenancy' : [sys.argv[4]],
                     'LocationOfTenancy' : [sys.argv[5]],
                     'ResidentAgeGroup' : [sys.argv[6]]})

with open('../application/Root/Cat_mapping/sex_mapping.pkl', 'rb') as pickle_file:
    sex_mapping = pickle.load(pickle_file)

with open('../application/Root/Cat_mapping/type_of_tenancy_mapping.pkl', 'rb') as pickle_file:
    type_of_tenancy_mapping = pickle.load(pickle_file)

with open('../application/Root/Cat_mapping/location_of_tenancy_mapping.pkl', 'rb') as pickle_file:
    location_of_tenancy_mapping = pickle.load(pickle_file)

with open('../application/Root/Cat_mapping/resident_age_group_mapping.pkl', 'rb') as pickle_file:
    resident_age_group_mapping = pickle.load(pickle_file)

for key, value in sex_mapping.items():
  if str(key) in str(data['Sex']) :
    data['Sex'] = value

for key, value in type_of_tenancy_mapping.items():
  if str(key) in str(data['TypeOfTenancy']) :
    data['TypeOfTenancy'] = value

for key, value in location_of_tenancy_mapping.items():
  if str(key) in str(data['LocationOfTenancy']) :
    data['LocationOfTenancy'] = value

for key, value in resident_age_group_mapping.items():
  if str(key) in str(data['ResidentAgeGroup']) :
    data['ResidentAgeGroup'] = value


#Import trained model

with open('../application/Root/MLModel/SVR_baseline.pkl', 'rb') as pickle_file:
    model = pickle.load(pickle_file)

# Import rescalers the model was trained on
rbX = joblib.load('../application/Root/Scalers/rbX.bin')
rbY = joblib.load('../application/Root/Scalers/rbY.bin')

#Rescale input and predict
data = rbX.transform(data)
prediction = model.predict(data)

#Rescale output back to original form
prediction = rbY.inverse_transform(prediction.reshape(-1, 1))

output = float (prediction)
print(output)";
        }

    }
}
