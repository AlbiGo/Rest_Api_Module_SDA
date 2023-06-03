//Add event listener on page load
if (document.readyState === 'loading') {  // Loading hasn't finished yet
    document.addEventListener('DOMContentLoaded', onload);
  } else {  // `DOMContentLoaded` has already fired
    onload();
  }

  function onload()
  {
    debugger;
    alert("Test")
    //Merr librat
    MerrLibrat();

  }

  function kryejVeprim()
  {
    debugger;
    var kontroll = true;
    var diviAktual = document.getElementById("div_ID");
    var div = document.getElementById("div_1");
    var numer1 = parseInt(document.getElementById("numer1_ID").value);
    if(isNaN(numer1)) //!typeof number 
    {
        HidhError("Inputi i pare nuk eshte numer");
        kontroll = false;
    }
    console.log(numer1);
    if(numer1 < 0)
    {
        HidhError("Inputi i pare eshte negativ");
        kontroll = false;
    }
    var numer2 = parseInt(document.getElementById("numer2_ID").value);
    console.log(numer2);
    if(isNaN(numer2)) //!typeof number 
    {
        HidhError("Inputi i dyte nuk eshte numer");
        kontroll = false;
    }
    if(numer2 < 0)
    {        
        HidhError("Inputi i dyte eshte negativ");
        kontroll = false;
    }
    if(kontroll == true)
    {
        var selektimi = document.getElementById("veprimi_ID").value;
        console.log(selektimi)
        var rezultati = 0;
        debugger;
        switch(selektimi)
        {
            case "shumezim" :
                rezultati = numer2 * numer1;
                break;
            case "pjestim" :
                rezultati = numer2 / numer1;
                break;
            case "mbledhje" :
                rezultati = numer2 + numer1;
                break;
            case "zbritje" :
                rezultati = numer2 - numer1;
                break;
        }
        var inputEgziston = document.getElementById("rezultati_ID");
        if(inputEgziston === null)
        {
            var input3 = document.createElement("input");
            input3.setAttribute('id', 'rezultati_ID');
            input3.setAttribute('type', 'number');
            diviAktual.appendChild(input3);
        }

        document.getElementById("rezultati_ID").value = rezultati;
    }
  }

  function HidhError(mesazhi)
  {
    var diviAktual = document.getElementById("div_ID");
    var mesazhError = document.createElement("p");
    mesazhError.setAttribute("id","mesazh_ID");
    diviAktual.appendChild(mesazhError);
    document.getElementById("mesazh_ID").innerText = mesazhi;//"Numri i dyte eshte negativ.Ju lutem vendosni nje numer pozitiv";
    document.getElementById("mesazh_ID").style.color = 'red';//"Numri i dyte eshte negativ.Ju lutem vendosni nje numer pozitiv";
  }

  function MerrLibrat()
  {
 //Http call settings
    const settings = {
      "async": true,
      "crossDomain": true,
      "url": "https://localhost:7178/api/v1/Liber/merrliberid?id=1",
      "method": "GET"
  };
  
  //Http call 
  $.ajax(settings).done(function (response) {
    console.log(response)
    // response = response;
   let data = response;
   document.getElementById("numer2_ID").value = data.titull;
    console.log(data)
});
}