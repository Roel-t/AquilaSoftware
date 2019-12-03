date = new Date().toLocaleTimeString('en-US', {
    hour12: true,
    hour: "numeric",
    minute: "numeric"
});
 

$("#time").append(date)
console.log(date)