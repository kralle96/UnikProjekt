import sys
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


with open('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Cat_mapping/sex_mapping.pkl', 'rb') as pickle_file:
    sex_mapping = pickle.load(pickle_file)

with open('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Cat_mapping/type_of_tenancy_mapping.pkl', 'rb') as pickle_file:
    type_of_tenancy_mapping = pickle.load(pickle_file)

with open('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Cat_mapping/location_of_tenancy_mapping.pkl', 'rb') as pickle_file:
    location_of_tenancy_mapping = pickle.load(pickle_file)

with open('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Cat_mapping/resident_age_group_mapping.pkl', 'rb') as pickle_file:
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

with open('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/MLModel/SVR_baseline.pkl', 'rb') as pickle_file:
    model = pickle.load(pickle_file)

# Import rescalers the model was trained on
rbX = joblib.load('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Scalers/rbX.bin')
rbY = joblib.load('C:/Users/Nichlas/Desktop/Projekt 3. semester/Bolig.Application/Root/Scalers/rbY.bin')

#Rescale input and predict
data = rbX.transform(data)
prediction = model.predict(data)

#Rescale output back to original form
prediction = rbY.inverse_transform(prediction.reshape(-1, 1))

output = float (prediction)
print(output)