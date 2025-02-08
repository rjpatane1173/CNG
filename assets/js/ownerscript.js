// Function to switch between login and register forms
function switchForm(formId) {
    document.querySelectorAll('.form-container').forEach((form) => {
        form.classList.remove('active');
    });
    document.getElementById(formId).classList.add('active');
}

// Handle Pump Owner Login
async function handlePumpOwnerLogin() {
    const email = document.getElementById('loginEmail').value;
    const password = document.getElementById('loginPassword').value;

    // Validate input fields
    if (!email || !password) {
        alert("Please fill in both email and password fields.");
        return;
    }

    try {
        const response = await fetch("https://cng-pump-finder-c8d7dbd4erezgqex.centralindia-01.azurewebsites.net/api/owners/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ email, password }),
        });

        if (response.ok) {
            const data = await response.json();
            
            // Debug log the full response for inspection
            console.log("Login Response:", data);

            // Check if the response contains the owner ID and store it
            if (data.id) {
                localStorage.setItem("Id", data.id);  // Store the owner ID
                alert(`Login successful! Welcome ${data.name}`);

                // Redirect to the Pump Owner Dashboard
                window.location.href = "pumpownerdashboard.html";
            } else {
                alert("Login successful but no valid ID found in response.");
                console.error("Invalid response structure:", data);
            }
        } else {
            const error = await response.json();
            alert(`Login failed: ${error.message || "Invalid credentials"}`);
        }
    } catch (error) {
        console.error("Error during login:", error);
        alert("An error occurred while attempting to login. Please try again later.");
    }
}

// Handle Pump Owner Register
async function handlePumpOwnerRegister() {
    const name = document.getElementById('registerName').value;
    const email = document.getElementById('registerEmail').value;
    const password = document.getElementById('registerPassword').value;
    const pumpname = document.getElementById('registerPumpName').value;
    const latitude = document.getElementById('registerLatitude').value;
    const longitude = document.getElementById('registerLongitude').value;

    // Validate input fields
    if (!name || !email || !password || !pumpname || !latitude || !longitude) {
        alert('Please fill in all fields correctly.');
        return;
    }

    try {
        const response = await fetch('https://cng-pump-finder-c8d7dbd4erezgqex.centralindia-01.azurewebsites.net/api/owners/register', { // Ensure HTTP or HTTPS is correct
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                name,
                email,
                password,
                pumpname,
                latitude,
                longitude
            }),
        });

        if (response.ok) {
            const data = await response.json();
            alert(`Registration successful! Welcome ${data.name}`);
            // Redirect to login or dashboard if needed
        } else {
            const contentType = response.headers.get('Content-Type');
            let errorMessage = 'An unknown error occurred.';

            if (contentType && contentType.includes('application/json')) {
                const errorData = await response.json();
                errorMessage = errorData.message || errorMessage;
            } else {
                errorMessage = await response.text();
            }

            alert(`Error: ${errorMessage}`);
        }
    } catch (error) {
        console.error('Error during registration:', error);
        alert('An error occurred while attempting to register. Please try again later.');
    }
}
