const students = [
    {
        name:"said",
        surname:"suleymanov",
        age:19
    },
    {
        name:"said",
        surname:"suleymanov",
        age:19
    },
    {
        name:"said",
        surname:"suleymanov",
        age:19
    },
    {
        name:"said",
        surname:"suleymanov",
        age:19
    }
]

let tbdy = document.createElement("tbody")
let table = document.createElement("table")

let arr = ["Name","Surname","Age"]

let thr = document.createElement("tr")
arr.forEach(x=>{
    let th = document.createElement("th")
    th.innerHTML=x;
    thr.appendChild(th)
})


table.appendChild(thr)


for (let i = 0; i < students.length; i++) {
    let tr = document.createElement("tr")
    let td = document.createElement("td")
    td.innerText = students[i].name
    td.style.border = "1px solid white"
    tr.appendChild(td)
    td = document.createElement("td")
    td.innerText = students[i].surname
    td.style.border = "1px solid white"
    tr.appendChild(td)
    td = document.createElement("td")
    td.innerText = students[i].age
    td.style.border = "1px solid white"
    tr.appendChild(td)
    tbdy.appendChild(tr)
}
table.appendChild(tbdy)
table.style.border = "1px solid white"
table.style.backgroundColor = "black"
table.style.color = "white"
table.style.margin = "0 auto"

document.body.appendChild(table)
