// Schüler hinzufügen
async function addStudent() {
    const studentData = {
        vorname: document.getElementById('vorname').value,
        nachname: document.getElementById('nachname').value,
        geschlecht: document.getElementById('geschlecht').value,
        geburtsdatum: document.getElementById('geburtsdatum').value,
        schoolClass: document.getElementById('schoolClass').value
    };

    const response = await fetch("/api/students", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(studentData)
    });

    if (response.ok) {
        const result = await response.json();
        alert("Schüler hinzugefügt: " + JSON.stringify(result));
    } else {
        alert("Fehler: " + (await response.text()));
    }
}

// Schüler löschen
async function deleteStudent() {
    const schoolClass = document.getElementById('deleteSchoolClass').value;
    const geburtsdatum = document.getElementById('deleteGeburtsdatum').value;

    const response = await fetch(`/api/students/${schoolClass}/${geburtsdatum}`, {
        method: "DELETE"
    });

    if (response.ok) {
        alert("Schüler gelöscht!");
        getStudents(); // Schülerliste aktualisieren
    } else {
        alert("Fehler: Schüler nicht gefunden!");
    }
}

// Schüler abrufen und anzeigen
async function getStudents() {
    const response = await fetch("/api/students");
    const students = await response.json();

    const studentsList = document.getElementById("studentsList");
    studentsList.innerHTML = "";

    students.forEach(s => {
        let li = document.createElement("li");
        li.textContent = `${s.vorname} ${s.nachname} | ${s.schoolClass} | ${s.geschlecht} | ${s.geburtsdatum}`;
        studentsList.appendChild(li);
    });
}
