
// NOTES
// ------------------------------------------------------
// - Coliders are for computer, mesh renderers are for human.
// Computer does not care about mesh renderes, only sees the coliders and vise versa.
// - If coldiers must be disabeled for player to walk through,
// just change it to a trigger. It is better.

// CODINIG RULES
// ------------------------------------------------------
// - bool should start with is -> isHungry
// - use camelback spacing -> moveSpeed
// - variables must have lower case names -> moveSpeed
// - functions/methods start with upper case names -> Start, Update
// - always use tabs for indentation never spaces
// - never put a semi column behind a brace -> };
// - GameManager game object = runs in background, never gets destroyed,
// controls stuff in the game
// - There are never spaces in a Script name


// VOCABULARY
// ------------------------------------------------------
// - Instantiate = create instance of an object
// - Instance = made out of prefab, there can be unlimited number of instances of an object
// - Reference variable = stores an address of a prefab, object, etc.
// - Exclusive = the value will neve be reached
// - Inclusive = the value counts into the selection

// BUILT IN FUNCTIONS
// ------------------------------------------------------
// - OnTriggerEnter = used to define what happens when objects trigger detects something
using System;

private void OnTriggerEnter (Collider other)


// VARIABLE TYPES
// ------------------------------------------------------
// - float = is not a while number, but decimal number 0.0005, always ends with an f, If i
// write an f behind a value computer automatically sees it as a float value
// usefull mainly in random number generation etc.
public float moveSpeed = 0.025f;
// - int = is a whole number, 1 2 3 4
public int health = 56;
// - GameObject
public GameObject bulletPrefab;
// - Refference variable = reffers to an object in project
public GameObject bulletPrefab;
// - Vector3 = variable that has three slots

// - Temporary variable = variable placed inside a function, gets restarted when function is done
void SpawnEnemy()
{
    Vector3 randomPos = Vector3.zero;
    Instantiate(enemyPrefab, randomPos, transform.rotation);
}

// COMPONENTS
// ------------------------------------------------------
// - Rigidbody - adds ability to object to work with physics engine
// - Rigidbody / Is Kinematic - sets the object to be part of the physics engine, BUT can be moved only by script, if kinematic is on -> disable use gravity
// - 

// CODE CALLS
// ------------------------------------------------------
// - INVOKE REPEATING = called only once, is NOT in update but start, repeatedly calls a function,
// set time (delay before starting the cycle), repeat rate
InvokeRepeating("SpawnEnemy", 0, 0.5f);
// - RANDOM RANGE = sets range between two values (min, max), returns random value
randomPos.x = Random.Range(-9, 9);


//CODE EXAMPLES
// ------------------------------------------------------
// Custom function
void Eat()
{
    print("Choose a food");
}

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

//Use of tags in an if statement
if (other.tag == "Baddies")
{
    Destroy(other.gameObject);
}

//Using vector in an custom function + setting the vector on the go
void SpawnEnemy()
{
    Vector3 randomPos = Vector3.zero;
    randomPos.x = Random.Range(-9, 9);
    randomPos.y = 9;
    randomPos.z = 0;
    Instantiate(enemyPrefab, randomPos, transform.rotation);
}