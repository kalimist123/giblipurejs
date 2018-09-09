// Create a request variable and assign a new XMLHttpRequest object to it.
var request = new XMLHttpRequest();

// Open a new connection, using the GET request on the URL endpoint

request.open('GET','http://localhost:5000/api/gibli',true);


request.onload = function(){

 //begin accessing JSON data here   
 var data = JSON.parse(this.response);

 if(request.status>=200 && request.status<400){
     data.forEach(movie=>{
         console.log(movie.title)
     })
 }else{
     console.log('error')
 }
}

request.send();