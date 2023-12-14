En la f�brica de juguetes del Polo Norte, cada juguete tiene un n�mero de identificaci�n �nico.

Sin embargo, debido a un error en la m�quina de juguetes, algunos n�meros se han asignado a m�s de un juguete.

�Encuentra el primer n�mero de identificaci�n que se ha repetido, donde la segunda ocurrencia tenga el �ndice m�s peque�o!

En otras palabras, si hay m�s de un n�mero repetido, debes devolver el n�mero cuya segunda ocurrencia aparezca primero en la lista. Si no hay n�meros repetidos, devuelve -1.

const giftIds = [2, 1, 3, 5, 3, 2]
const firstRepeatedId = findFirstRepeated(giftIds)
console.log(firstRepeatedId) // 3
// Aunque el 2 y el 3 se repiten
// el 3 aparece primero por segunda vez

const giftIds2 = [1, 2, 3, 4]
const firstRepeatedId2 = findFirstRepeated(giftIds2)
console.log(firstRepeatedId2) // -1
// Es -1 ya que no se repite ning�n n�mero

const giftIds3 = [5, 1, 5, 1]
const firstRepeatedId3 = findFirstRepeated(giftIds3)
console.log(firstRepeatedId3) // 5