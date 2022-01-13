

/*
 * Determine the original side lengths and return an array:
 * - The first element is the length of the shorter side
 * - The second element is the length of the longer side
 * 
 * Parameter(s):
 * literals: The tagged template literal's array of strings.
 * expressions: The tagged template literal's array of expression values (i.e., [area, perimeter]).
 */
function sides(literals, ...expressions) {
    let area = expressions[0];
    let perim = expressions[1];
    
    let s1 = (perim + descrim(perim, area)) / 4; 
    let s2 = (perim - descrim(perim, area)) / 4; 
    
    return [s2, s1];
}

function descrim(perim, area)
{
    return Math.sqrt(Math.pow(perim, 2) - 16 * area);
}

