const app = document.getElementById('root')

const container = document.createElement('div')
container.setAttribute('class', 'row')


app.appendChild(container)

var request = new XMLHttpRequest()
request.open('GET', 'https://ghibliapi.herokuapp.com/films', true)
request.onload = function () {
    // Begin accessing JSON data here
    var data = JSON.parse(this.response)
    if (request.status >= 200 && request.status < 400) {
        data.forEach((movie) => {
            const card = document.createElement('div')
            card.setAttribute('class','col-3 col-sm-3')

            const cardbody = document.createElement('div')
            cardbody.setAttribute('class', 'card-body bg-dark-purple rounded')

            const h1 = document.createElement('h3')
            h1.textContent = movie.title

            const p = document.createElement('p')
            movie.description = movie.description.substring(0, 300)
            p.textContent = `${movie.description}...`

            container.appendChild(card)
            card.appendChild(cardbody)
            cardbody.appendChild(h1)
            cardbody.appendChild(p)
        })
    } else {
        const errorMessage = document.createElement('marquee')
        errorMessage.textContent = `Gah, it's not working!`
        app.appendChild(errorMessage)
    }
}

request.send()