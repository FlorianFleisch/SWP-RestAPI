async function add1ToNumb1() {
    const input1 = parseInt(document.getElementById("input1a").value);
    const response = await fetch(`http://localhost:5059/api/Addiert1zuInput/${input1}`, {
        method: "PUT"
    });
    if (!response.ok) {
        document.getElementById("result1").innerText = "Fehler: " + (await response.text());
        return;
    }
    const result = await response.json();
    document.getElementById("result1").innerText = result;
}

async function addNumbersWithAPI() {
    const input1 = parseInt(document.getElementById("input1b").value);
    const input2 = parseInt(document.getElementById("input2").value);
    const data = { Input1: input1, Input2: input2 };
    const response = await fetch("http://localhost:5059/api/sumOfInputs/sumOfNumbers", {
        method: "PUT",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
    });
    const result = await response.json();
    document.getElementById("result2").innerText = result;
}