
function hashStringToInt(s, tableSize){
    let hash = 17;

    for(let i = 0; i < s.length; i++){
        hash = (13 * hash * s.charCodeAt(i)) % tableSize
    }

    return hash;
} 

class HashTable {
    
    table = new Array(3);    

    setItme = (key, value) => {
        const index = hashStringToInt(key, this.table.length);

        if(this.table[index]){
            this.table[index].push({key, value});
        } else {
            this.table[index] = [{key, value}];
        }
        
    }

    getItem = (key) => {
        const index = hashStringToInt(key, this.table.length);

        if(!this.table[index]){
            return null;
        }
        
        return this.table[index].find(x => x.key === key).value;
        
    }    
}


const myTable = new HashTable();
myTable.setItme('firstName', 'bob');
myTable.setItme('lastName', 'tim');
myTable.setItme('age', 22);
myTable.setItme('gender', 'male');

console.log(myTable.table[0]);
console.log(myTable.getItem('firstName'))
console.log(myTable.getItem('lastName'))
console.log(myTable.getItem('age'))
console.log(myTable.getItem('gender'))