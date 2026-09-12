import requests

base_url = "api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=449a5f8156bf2a6a32a3a9dd48f8408e"

first_url = "api.openweathermap.org/data/2.5/weather?q="
last_url = "&APPID=449a5f8156bf2a6a32a3a9dd48f8408e"

user_city = input("Hello, enter the city please: ")
user_country = input("Please enter also the country name: ")
final_url = f"{"https://"}{first_url}{user_city}{","}{user_country}{last_url}{"&units=metric&lang=us"}"

def convert_to_fahrenheit(Celcius):
    fahr = (Celcius * 9/5) + 32
    return fahr

def convert_to_kelvin(Celcius):
    Kelvin = Celcius + 273
    return Kelvin

response = requests.get(final_url)
if response.status_code == 200: 
    data = response.json()
    #name
    name = data["name"]

    #temperature etc.
    temp = data["main"]["temp"]
    feels_like = data["main"]["feels_like"]
    pressure = data["main"]["pressure"]
    
    #weather
    weather = data["weather"][0]["main"]
    weather_desc = data["weather"][0]["description"]
    icon = data["weather"][0]["icon"]
    wind_speed = data["wind"]["speed"]


    #converting

    fahr1 = convert_to_fahrenheit(temp)
    kelvin1 = convert_to_kelvin(temp)

    #printing
    
    print("="*30)
    print(f"="*30) 
    print(f"      {name} WEATHER")
    print("="*30)
    print("="*30)
    print(f"TEMPERATURE = {temp} Celcius degree")
    print(f"TEMPERATURE = {fahr1} Fahrenheit degree")
    print(f"TEMPERATURE = {kelvin1} Kelvin degree")
    print(f"FEELS LIKE = {feels_like} Celcius degree")
    print(f"PRESSURE = {pressure}")
    print(f"WEATHER = {weather}")
    print(f"WEATHER DESCRIPTION = {weather_desc}")
    print(f"WIND SPEED = {wind_speed}")

else:
    print("The requested data could not be retrieved!")
