const getlejemaalApi = document.getElementById('lejemaalApi')

const newDiv = document.createElement('div')
newDiv.setAttribute('class', 'row')

var request = new XMLHttpRequest()
request.open('GET', 'http://localhost:44373/GetAllLejemaal', true)

request.onload = function()
{
    var getData = JSON.parse(this.response)

    if (request.status >= 200 && request.status < 400)
    {
        getData.forEach((lejemaal) => {
            const card = document.createElement('div')
            card.setAttribute('class', 'col-3 col-sm-3')

            const cardbody = document.createElement('div')
            cardbody.setAttribute('class', 'card-body bg-dark-purple rounded')

            const h1 = document.createElement('h3')
            h1.textContent = lejemaal.Adresse

            //const p = document.createElement('p')
            //movie.description = lejemaal.description.substring(0, 300)
            //p.textContent = `${lejemaal.description}...`

            container.appendChild(card)
            card.appendChild(cardbody)
            cardbody.appendChild(h1)
            //cardbody.appendChild(p)
        })
    }
    else {
        const errorMessage = document.createElement('marquee')
        errorMessage.textContent = `Gah, it's not working!`
        app.appendChild(errorMessage)
    }

}

request.send();