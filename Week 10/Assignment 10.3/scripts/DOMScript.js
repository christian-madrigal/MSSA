document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('position').addEventListener('click', showPosition)
});

function showPosition() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            let positioninfo = "Your current location is (" + "Latitude:" + position.coords.latitude + " Longitude :" + position.coords.longitude + ")";
            document.getElementById("position").innerHTML = positioninfo;
        });
    }
    else { alert("No geolocation data avilable"); }
}