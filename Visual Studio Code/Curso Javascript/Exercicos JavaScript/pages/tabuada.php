<title>Tabuada</title>

<div class="container-tabuada">
    <h1 class="titulo-tabuada">Tabuada</h1>
    <div class="div-tabuada">
        <div class="div-ipt-tabuada">
            <input type="number" class="ipt-tabuada" placeholder="Insira um número">
            <button class="btn-tabuada">Gerar Tabuada</button>
        </div>
        <div class="div-select-tabuada">
            <select id="" class="select-tabuada">
                <option value="">Gere uma tabuada</option>
            </select>
        </div>
    </div>
</div>

<style>
    .container-tabuada{
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;

        height: 87vh;
    }
    .titulo-tabuada{
        color: white;
        font-size: 35px;
    }
    .div-tabuada{
        display: flex;
        align-items: center;
        justify-content: space-between;
        flex-direction: column;

        height: 300px;
        width: 250px;
        padding: 20px;
        background: white;
        border-radius: 20px;
        box-shadow: 0 0 15px black;
    }
    .div-ipt-tabuada{
        display: flex;
        justify-content: space-between;
        align-items: center;

        width: 100%;
        height: 20%;
    }
    .div-ipt-tabuada input{
        border: solid 2px black;
        box-shadow: 0 0 7px black;
        border-radius: 50rem;
        height: 40px;
        width: 60%;
        padding-left: 10px;
        transition: .4s;
    }
    .div-ipt-tabuada input:focus{
        box-shadow: 0 0 25px yellow;
    }
    .div-ipt-tabuada input::placeholder{
        font-size: 13px;
    }
    .div-ipt-tabuada button{
        text-align: center;
        background: black;
        color: white;
        border: none;
        cursor: pointer;
        box-shadow: 0 0 7px black;
        height: 40px;
        width: 30%;
        font-size: 12px;
        border-radius: 5px;
        transition: .4s;
    }
    .div-ipt-tabuada button:hover{
        background: rgb(27, 27, 27);
    }
    .div-ipt-tabuada button:active{
        transform: scale(0.9);
    }
    .div-select-tabuada{
        display: flex;
        justify-content: center;

        width: 100%;
        height: 80%;
    }
    .select-tabuada{
        width: 100%;
        height: 40px;
        margin-top: 10px;
    }
</style>