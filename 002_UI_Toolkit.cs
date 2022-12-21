// TERMINOLOGY
// --------------------------------------------------------------
// * Main/Corss-Axis
// * Flex-Direction
// * Aligning
// * Flex-Basis
// * Shrink/Grow
// * Combinations

// FLEXBOX TERMINOLOGY
// --------------------------------------------------------------
// * Container - contains other elements inside, there can be container in container
// * Item - an end element, like item in an inventory
// * Main / Cross Axis - they can be interchanged, it is not like x axis is always horizontal
// the Flex Direction decides which is which, each axis has different rules and designer
// needs to choose based on the usecase
// * Flex Direction - only two states (COLUMN / ROW), is set on every container,
// states flip the axis, ROW state, COLUMN state, if COLUMN
// state used the Main Axis is on the Y Axis. If ROW tate used, the Main Axis is on the X Axis
// * Elements compete for space, and the settings in properties define how they do it
// * Elements tell what they need, Parent tells child elements how they are distributed on the screen
// eample is inventory, where the main square is the parent, and the inventory fields are children
// * The more contents a container has, the more impact it has on the layout
// * It is a game of elements and their weight, where Flex box tries to create the UI based on 
// the set UI
// * The properties of an element define how much the element will retreet or expand based on space
// it is given and how it will compete with other elements for the available space
// * Some of the values, like grow can define strength that elements compare but also to completely
// define that an element will never fight for the extra available space or even retreet
// * The basic layout can be achieved just with correct settin of Flex shringk and grow + basis value

// PROPERTIES
// --------------------------------------------------------------
// * Flex/Basis - size of the element on main axis the element wants to have, it always 
// streches on corss axis, basis is the ideal size the element wants to have
// * Flex/Basis/Shrink = 1 - if there is not enough space to sue the Basis value, scale down
// * Flex/Basis = %, Auto - in % it has relative value compare to its parent, % is used the most
// in UI as it makes the UI work no matter the resolution, PX is used mainly for pictures,
// auto says "look a the content you have and automatically calculate the size of element"
// * Flex/Shrink + Grow - it is not bool value 0/1, it can go higher than 1 and define ration of how
// elements get distributed, the shring and grow works in a way that it compares values set on other
// elements and the setting of the parent object, the basis value is used to calculate how Shrink and
// Grow effects the element
// * Size - fixed height or width
// * Basis set to 0 % means that the Flex ignores the basis value and follows strictly Shrink and Grow settings