let map, directionsService, directionsRenderer;

function initMap() {
    // Initialize the Google Map
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 37.7749, lng: -122.4194 }, // Default to San Francisco
        zoom: 8,
    });

    // Initialize the Directions Service and Renderer
    directionsService = new google.maps.DirectionsService();
    directionsRenderer = new google.maps.DirectionsRenderer();
    directionsRenderer.setMap(map);
}

// Function to find and display the route
document.getElementById("findRoute").addEventListener("click", () => {
    const startLocation = document.getElementById("start").value;
    const destination = document.getElementById("destination").value;

    if (!startLocation || !destination) {
        alert("Start location and destination are required.");
        return;
    }

    // Call the Directions API
    directionsService.route(
        {
            origin: startLocation,
            destination: destination,
            travelMode: google.maps.TravelMode.DRIVING, // Change to WALKING, BICYCLING, or TRANSIT as needed
        },
        (response, status) => {
            if (status === google.maps.DirectionsStatus.OK) {
                // Display the route on the map
                directionsRenderer.setDirections(response);
            } else {
                alert("Directions request failed due to " + status);
            }
        }
    );
});

// Initialize the map when the window loads
window.onload = initMap;
