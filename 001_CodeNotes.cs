
// NOTES
// ------------------------------------------------------
// - Coliders are for computer, mesh renderers are for human. Computer does not care about mesh renderes, only sees the coliders and vise versa.
// - If coldiers must be disabeled for player to walk through, just change it to a trigger. It is better.

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

// BUILT IN FUNCTIONS
// ------------------------------------------------------
// - OnTriggerEnter = used to define what happens when objects trigger detects something
private void OnTriggerEnter (Collider other)


// VARIABLE TYPES
// ------------------------------------------------------
// - float
public float moveSpeed;
// - GameObject
public GameObject bulletPrefab;

// COMPONENTS
// ------------------------------------------------------
// - Rigidbody - adds ability to object to work with physics engine
// - Rigidbody / Is Kinematic - sets the object to be part of the physics engine, BUT can be moved only by script, if kinematic is on -> disable use gravity
// - 

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

//Prints out name of the object that hit the collider + destroys any game object it touches
private void OnTriggerEnter(Collider other)
{
    print(other.name);

    Destroy(other.gameObject);
}