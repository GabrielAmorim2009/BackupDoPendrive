let iptnome = document.getElementsByClassName('input-nome')[0]
let iptemail = document.getElementsByClassName('input-email')[0]
let ipttelefone = document.getElementsByClassName('input-telefone')[0]
let iptcidade = document.getElementsByClassName('input-cidade')[0]
let iptestado = document.getElementsByClassName('input-estado')[0]
let iptendereco = document.getElementsByClassName('input-endereco')[0]
let lblnome = document.getElementsByClassName('lbl-nome')[0]
let lblemail = document.getElementsByClassName('lbl-email')[0]
let lbltelefone = document.getElementsByClassName('lbl-telefone')[0]
let lblcidade = document.getElementsByClassName('lbl-cidade')[0]
let lblestado = document.getElementsByClassName('lbl-estado')[0]
let lblendereco = document.getElementsByClassName('lbl-endereco')[0]

iptnome.addEventListener("keyup", () => {
    if (iptnome.value.length != 0) {
        lblnome.style.transform = "translateY(-28px)"
        lblnome.style.fontSize = "10px"
        iptnome.addEventListener("focus", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "10px"
        })
        iptnome.addEventListener("focusout", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "10px"
        })
    }
    else if (iptnome.value.length < 1) {
        lblnome.style.transform = "translateY(-9px)"
        lblnome.style.fontSize = "12px"
        iptnome.addEventListener("focus", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "10px"
        })
        iptnome.addEventListener("focusout", () => {
            lblnome.style.transform = "translateY(-9px)"
            lblnome.style.fontSize = "12px"
        })
    }
})

iptemail.addEventListener("keyup", () => {
    if (iptemail.value.length != 0) {
        lblemail.style.transform = "translateY(-28px)"
        lblemail.style.fontSize = "10px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "10px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "10px"
        })
    }
    else if (iptemail.value.length < 1) {
        lblemail.style.transform = "translateY(-9px)"
        lblemail.style.fontSize = "12px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "10px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-9px)"
            lblemail.style.fontSize = "12px"
        })
    }
})

ipttelefone.addEventListener("keyup", () => {
    if (ipttelefone.value.length != 0) {
        lbltelefone.style.transform = "translateY(-28px)"
        lbltelefone.style.fontSize = "10px"
        ipttelefone.addEventListener("focus", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "10px"
        })
        ipttelefone.addEventListener("focusout", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "10px"
        })
    }
    else if (ipttelefone.value.length < 1) {
        lbltelefone.style.transform = "translateY(-9px)"
        lbltelefone.style.fontSize = "12px"
        ipttelefone.addEventListener("focus", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "10px"
        })
        ipttelefone.addEventListener("focusout", () => {
            lbltelefone.style.transform = "translateY(-9px)"
            lbltelefone.style.fontSize = "12px"
        })
    }
})

iptcidade.addEventListener("keyup", () => {
    if (iptcidade.value.length != 0) {
        lblcidade.style.transform = "translateY(-28px)"
        lblcidade.style.fontSize = "10px"
        iptcidade.addEventListener("focus", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "10px"
        })
        iptcidade.addEventListener("focusout", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "10px"
        })
    }
    else if (iptcidade.value.length < 1) {
        lblcidade.style.transform = "translateY(-9px)"
        lblcidade.style.fontSize = "12px"
        iptcidade.addEventListener("focus", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "10px"
        })
        iptcidade.addEventListener("focusout", () => {
            lblcidade.style.transform = "translateY(-9px)"
            lblcidade.style.fontSize = "12px"
        })
    }
})

iptestado.addEventListener("keyup", () => {
    if (iptestado.value.length != 0) {
        lblestado.style.transform = "translateY(-28px)"
        lblestado.style.fontSize = "10px"
        iptestado.addEventListener("focus", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "10px"
        })
        iptestado.addEventListener("focusout", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "10px"
        })
    }
    else if (iptestado.value.length < 1) {
        lblestado.style.transform = "translateY(-9px)"
        lblestado.style.fontSize = "12px"
        iptestado.addEventListener("focus", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "10px"
        })
        iptestado.addEventListener("focusout", () => {
            lblestado.style.transform = "translateY(-9px)"
            lblestado.style.fontSize = "12px"
        })
    }
})

iptendereco.addEventListener("keyup", () => {
    if (iptendereco.value.length != 0) {
        lblendereco.style.transform = "translateY(-28px)"
        lblendereco.style.fontSize = "10px"
        iptendereco.addEventListener("focus", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "10px"
        })
        iptendereco.addEventListener("focusout", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "10px"
        })
    }
    else if (iptendereco.value.length < 1) {
        lblendereco.style.transform = "translateY(-9px)"
        lblendereco.style.fontSize = "12px"
        iptendereco.addEventListener("focus", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "10px"
        })
        iptendereco.addEventListener("focusout", () => {
            lblendereco.style.transform = "translateY(-9px)"
            lblendereco.style.fontSize = "12px"
        })
    }
})