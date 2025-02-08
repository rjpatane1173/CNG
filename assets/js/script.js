// Function to switch between login and register forms
function switchForm(formId) {
    document.querySelectorAll('.form-container').forEach((form) => {
      form.classList.remove('active');
    });
    document.getElementById(formId).classList.add('active');
  }
  
  // Handle Login
  async function handleLogin() {
    const email = document.getElementById('loginEmail').value;
    const password = document.getElementById('loginPassword').value;

    // Validate input fields
    if (!email || !password) {
        alert("Please fill in both email and password fields.");
        return;
    }

    try {
        const response = await fetch("https://cng-pump-finder-c8d7dbd4erezgqex.centralindia-01.azurewebsites.net/api/drivers/login", {  // Update URL here if needed
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ email, password }),
        });

        if (response.ok) {
            const data = await response.json();
            alert(`Login successful! Welcome ${data.name}`);
            
            // Redirect to the Driver Dashboard
            window.location.href = "driverdashboard.html"; // Update with the correct dashboard path
        } else {
            const error = await response.json();  // Assuming the API returns a JSON error message
            alert(`Login failed: ${error.message || "Invalid credentials"}`);
        }
    } catch (error) {
        console.error("Error during login:", error);
        alert("An error occurred while attempting to login. Please try again later.");
    }
}

  
  
  // Handle Register
  async function handleRegister() {
    const name = document.getElementById('registerName').value;
    const email = document.getElementById('registerEmail').value;
    const password = document.getElementById('registerPassword').value;
    const phone = document.getElementById('registerPhone').value;
    const carBrand = document.getElementById('registerCarBrand').value;
    const maxCapacity = document.getElementById('registerMaxCapacity').value;

    // Validate input fields
    if (!name || !email || !password || !phone || !carBrand || !maxCapacity) {
        alert('Please fill in all fields.');
        return;
    }

    try {
        const response = await fetch("https://cng-pump-finder-c8d7dbd4erezgqex.centralindia-01.azurewebsites.net/api/drivers/register", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                name,
                email,
                password,
                phone,
                carBrand,
                maxCapacity: parseInt(maxCapacity), // Ensure maxCapacity is a number
            }),
        });

        if (response.ok) {
            // Parse JSON only if the response is OK
            const data = await response.json();
            alert(`Registration successful! Welcome ${data.name}`);
        } else {
            // Handle errors based on content type
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

/*  
Step Action	               Actor	     Example
1	User fills the form	   User	             Enters name, email, password, phone, etc.
2	User clicks "Register"	Frontend (HTML)	 Button triggers handleRegister.
3	Data is collected and validated	Frontend (JS)	Ensures all fields are filled.
4	Data sent to backend via API	Frontend (JS)	POST request with JSON data.
5	Data validated and saved	Backend (Java)	Checks @NotBlank, saves to database.
6	Response sent back	Backend (Java)	Success or error response returned.
7	Success/error displayed to user	Frontend (JS/HTML)	Shows alert for success or error.*/
