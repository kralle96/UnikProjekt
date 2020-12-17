

const api_url =
    "https://localhost:44352/Api/GetAllLejemaal";

// Defining async function 
async function getapi(url) {

    // Storing response 
    const response = await fetch(url);

    // Storing data in form of JSON 
    var data = await response.json();
    console.log(data);
    if (response) {
        hideloader();
    }
    show(data);
}
// Calling that async function 
getapi(api_url);

// Function to hide the loader 
function hideloader() {
    document.getElementById('loading').style.display = 'none';
}
// Function to define innerHTML for HTML table 
function show(data) {
    let tab =
        `<tr> 
          <th>Lejemåls Id</th> 
          <th>Adresse</th> 
        
          <th>vaerelser</th> 
          <th>Energimærke</th> 
          <th>Type</th> 
          <th>Størrelse</th> 
         </tr>`;

    // Loop to access all rows  
    for (let r of data) {
        tab += `<tr>  
    <td>${r.lejemaalsId} </td> 
    <td>${r.adresse}</td> 
      
    <td>${r.vaerelser}</td>   
    <td>${r.energimaerke}</td>  
    <td>${r.type}</td>  
    <td>${r.stoerrelse}</td>  

</tr>`;
    }
    // Setting innerHTML as tab variable 
    document.getElementById("her").innerHTML = tab;
} 