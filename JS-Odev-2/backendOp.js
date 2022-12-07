let todoFormDOM = document.querySelector("#userForm")
todoFormDOM.addEventListener("submit", formHandler)

function formHandler(event){
    event.preventDefault()
    let input = document.querySelector("#todoInput")
    addItem(input.value)
}

let todoListDOM = document.querySelector("#todoList")

const addItem = (message) => {
    let liDOM = document.createElement("li")
    liDOM.innerHTML = `${message}
    <button type="reset" class="btn-close" aria-label="Close"></button>
    `
    liDOM.classList.add('list-group-item', 'd-flex', 'justify-content-between', 'align-items-center')
    todoListDOM.append(liDOM)
}