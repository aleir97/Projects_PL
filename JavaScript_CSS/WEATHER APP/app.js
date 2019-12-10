function fh_to_celsius(f) {
	var c;
	c =(f.farenheit - 32) * (5/9); 
	
    return Math.round(c);
}

function miles_to_km(f) {
	var km;
	km = f.wind *  1.609; 
	
    return Math.round(km);
}


// Obj that represents a measure of weather
var measure = {
	farenheit: 30,
    condition: "rainy",
    wind: 5,
    rain: 10
};

// Temperature details
temp = document.getElementById("tempC");
tempC = fh_to_celsius(measure);

// Wind details
wind = document.getElementById("wind");
wind_speed = miles_to_km(measure);

// Display temperatures in Celsius:
document.getElementById("tempC").innerHTML +=
    "Temp in Celsius: " + tempC + "<sup>o</sup>C";
// Display wind:
document.getElementById("wind").innerHTML +=
    "The wind speed is: " + wind_speed + " <sup>km</sup>/<sub>h</sub>";

// If that controls which image will appear according the weather
if (measure.condition == "sunny")
    document.getElementById("condition").innerHTML =  "<img id = conditions class = center src = images/sunny.png>";
else if (measure.condition == "cloudy")
    document.getElementById("condition").innerHTML =  "<img id = conditions class = center src = images/cloudy.png>";
else if (measure.condition == "rainy")
    document.getElementById("condition").innerHTML =  "<img id = conditions class = center src = images/rainy.png>";
else if (measure.condition == "cold")
    document.getElementById("condition").innerHTML =  "<img id = conditions class = center src = images/cold.png>";

// If that controls the style of the temperature according the weather
if (tempC < 5)
    temp.style.color = "blue";


// Controling geolocation
var location = document.getElementById("location");  
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    }else {
        location.innerHTML += "Geolocation is not supported by this browser.";
    }
}

function showPosition(position) {	
    location.innerHTML = "<br>Latitude: " + position.coords.latitude +
        "<br>Longitude: " + position.coords.longitude;
}



getLocation();






