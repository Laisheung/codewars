export function numPrimorial(totalNumberOfPrimes: number) {
    // loop through numbers untill you have n numbers of prime
    let numberOfPrimesFound = 0;
    let sum = 1;
    for(let currentNumber = 2; numberOfPrimesFound < totalNumberOfPrimes; currentNumber++){
        if(isPrime(currentNumber)){
            numberOfPrimesFound++;
            sum*=currentNumber;
        }
    }

    return sum;
 }

function isPrime(n: number): boolean {
    if (n <= 1) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    var boundary = Math.floor(Math.sqrt(n));
          
    for (let i = 3; i <= boundary; i += 2){
        if (n % i == 0){
            return false;
        }
    }

    return true;
}
