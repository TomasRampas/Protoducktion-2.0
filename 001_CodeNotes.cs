
// CODINIG RULES
// ------------------------------------------------------
// - bool should start with is -> isHungry
// - use camelback spacing -> moveSpeed
// - variables must have lower case names -> moveSpeed
// - functions/methods start with upper case names -> Start, Update
// - always use tabs for indentation never spaces
// - never put a semi column behind a brace -> };


// VOCABULARY
// ------------------------------------------------------
// - Instantiate = create instance of an object
// - Instance = made out of prefab, there can be unlimited number of instances of an object
// - Reference variable = stores an address of a prefab, object, etc.


// VARIABLE TYPES
// ------------------------------------------------------
// - float
public float moveSpeed;
// - GameObject
public GameObject bulletPrefab;

//CODE EXAMPLES
// ------------------------------------------------------
//Move object
transform.Translate(Vector3.up * speed);

//Do seomthing whe key is pressed
if (Input.GetKey(KeyCode.LeftArrow))
{
    transform.Translate(Vector3.left * moveSpeed);
}

//Instantiate a bullet object in player cube
Instantiate(bulletPrefab, transform.position, transform.rotation);