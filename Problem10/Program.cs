var primeNumbers = new List<long>() {2,3,5,7,11,13};
long i = 15;
long sum = primeNumbers.Sum();
while(i < 2000000){
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
        sum += i;
	}
	i+=2;
}	
Console.WriteLine(sum);	