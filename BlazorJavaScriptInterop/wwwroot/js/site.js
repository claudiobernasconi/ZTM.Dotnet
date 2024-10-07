function showMessage(message) {
    alert(message)
}

function calculateAge(yearOfBirth) {
    const currentYear = new Date().getFullYear()
    return currentYear - yearOfBirth
}
