function logoutDriver() {
    fetch('https://cng-pump-finder-c8d7dbd4erezgqex.centralindia-01.azurewebsites.net/api/drivers/logout', { // Use the correct API route
        method: 'POST',
        credentials: 'include' // Ensure cookies/session data are included
    })
    .then(response => {
        if (response.ok) {
            // Clear local session storage
            sessionStorage.clear();
            localStorage.removeItem("driver_session");

            // ✅ Show an alert box
            alert("Logout successful!");

            // Redirect to login page after alert
            window.location.href = "driversignin.html";
        } else {
            alert("Logout failed! Please try again.");
            console.error("Logout failed!");
        }
    })
    .catch(error => {
        alert("Error during logout. Please check the console.");
        console.error("Error during logout:", error);
    });
}

// ✅ Attach event listener to logout button
document.addEventListener("DOMContentLoaded", function() {
    let logoutButton = document.getElementById("logoutButton");
    if (logoutButton) {
        logoutButton.addEventListener("click", logoutDriver);
    }
});
