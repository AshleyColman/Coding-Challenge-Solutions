

/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    for(let i = 0;i < s.length; i++)
    {
        printIfVowel(s[i]);
    }
    
    for(let i = 0;i < s.length; i++)
    {
        printIfNotVowel(s[i]);
    }
}

function printIfVowel(s)
{
        const vowels = ["a", "e", "i", "o", "u"];
        for(let i = 0;i < vowels.length; i++)
        {
            if (s == vowels[i])
            {
                console.log(s);
                break;
            }
        }
}

function printIfNotVowel(s)
{
        const vowels = ["a", "e", "i", "o", "u"];
        let foundVowel = false;
        for(let i = 0;i < vowels.length; i++)
        {
            if (s == vowels[i])
            {
                foundVowel = true;
                break;
            }
        }
        
        if (foundVowel == false)
        {
            console.log(s);
        }
}

