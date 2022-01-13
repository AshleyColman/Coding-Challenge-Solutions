

/*
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
function reverseString(s) {
    try{
        let split = s.split("");
        let reverse = split.reverse();
        let joined = reverse.join("");
        s = joined;
    }
    catch (e){
        console.log(e.message);
    }
    console.log(s);
}

