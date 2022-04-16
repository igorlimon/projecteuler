var primeNumbers = new List<long>() {2,3,5,7,11,13};
var i = 15;
while(primeNumbers.Count <= 10001){
	bool isPrime = true;
	foreach(var n in primeNumbers){
		if(i % n == 0 ){
			isPrime = false;
			break;
		} else if(n*2 >=i){
			break;
		}
	}
	if(isPrime){
		primeNumbers.Add(i);
	}
	i+=2;
}	
Console.WriteLine(primeNumbers[10001]);	