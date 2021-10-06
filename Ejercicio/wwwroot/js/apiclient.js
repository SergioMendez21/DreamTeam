function Onsuma() {
    getSuma(sumandoA.value, sumandoB.value);
}

function getDate() {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        console.log(resp.currentTarget.response);
    }
    req.open("GET","Api/getDate");
    req.send();
}
function getInfo() {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        let r = JSON.parse(resp.currentTarget.response);
        console.log(r);
    }
    req.open("GET", "Api/getInfo");
    req.send();
}
function getPersona() {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        let r = JSON.parse(resp.currentTarget.response);
        console.log(r.id);
    }
    req.open("GET", "Api/getPersona");
    req.send();
}
function getList() {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        if (resp.currentTarget.Status == 200) {
            let r = JSON.parse(resp.currentTarget.response);
            console.log(r);
        } else {
            console.log("ERROR:" + resp.currentTarget.Status + " " + resp.currentTarget.response);
        }
    }
    req.open("GET", "Api/getList");
    req.send();
}
function getDetalle() {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        let r = JSON.parse(resp.currentTarget.response);
        console.log(r.id);
    }
    req.open("GET", "Api/getDetalle" + id);
    req.send();
}

function getSuma(a, b) {
    var req = new XMLHttpRequest();
    req.onload = function (resp) {
        if (resp.currentTarget.status == 200) {
            let r = JSON.parse(resp.currentTarget.response);
            console.log(r);
            resultado.innerHTML = r.r
        } else {
            console.log("ERROR:" + resp.currentTarget.Status + " " + resp.currentTarget.response);
        }
    }
    //req.open("GET", "Api/Suma?a="+a+"&b="+b);
    //req.send();
    req.open("POST", "Api/Suma");
    req.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    req.send(JSON.stringify({"a":a, "b":b}));
}