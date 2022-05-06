document.addEventListener('DOMContentLoaded',()=>
{
    const loadTodosButton = document.getElementById(`load-todos-button`);
    const dataComponent = document.getElementById(`data-component`);
    const errorComponent = document.getElementById(`error-component`);

    loadTodosButton.addEventListener('click', () =>
    {
        fetch(`https://jsonplaceholder.tyicode.com/todos`)
            .then(response =>
                {
                    if(!response.ok)
                    {
                        throw new Error(`Server error: ${response.status}`);
                    }
                    return response.json();
                })
                .then(obj =>
                    {
                        errorComponent.hidden = true;
                        let html = `<ul>` + obj.map(x =>`<li>${x.title}</li>`).join('') + `<ul>`;
                        dataComponent.innerHTML = html;
                    })
                .catch(error =>
                    {
                        errorComponent.hidden = false;
                        errorComponent.innerHTML = `<p>${error.message}</p>`;
                        dataComponent.textContent = '';
                    })
        });

        loadUserButton.addEventListener(`click`, () =>
        {
            fetch(`https://jsonplaceholder.typicode.com/users`)
            .then( response =>
                {
                    if (!response.ok)
                    {
                        throw new Error(`Server error: ${response.status}`);
                    }
                    return response.json();
                })
                .then( obj =>
                    {
                        errorComponent.hidden = true;
                        displayData(obj, );
                    })
                .catch(error =>
                    {
                        errorComponent.hidden = false;
                        errorComponent.innerHTML = `<p>${error.message}</p>`;
                        dataComponent.textContent = '';
                    })        

    });
});

function displayData(users, dataComponent)
{
    let html = '';

    html += `<ul>`
    for (let user of users)
    {
        html +=`<li>${user.name}</li>`;
    }
    html += `</ul>`;
    dataComponent.innerHTML = html;
}

// Callbanks
// JavaScript allows us to pass a function as a parameter
// a function in Javascript is an object

function printSomething(x)
{
    console.log(x);
}

function addWithCallback(x,y, callback)
{
    let result = x + y;
    callback(result);
}

addWithCallback('hi','Kevin',printSomething);
addWithCallback('welcome back','Kevin',printSomething);