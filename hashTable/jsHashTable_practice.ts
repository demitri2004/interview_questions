function hashFunc(key, tableSize){
    console.log(key[0].charCodeAt() % tableSize);
    return key[0].charCodeAt() % tableSize;
}

class HashTable2 {
    table = new Array(4);

    setElement(key, value){
        const idx = hashFunc(key, this.table.length);

        if(this.table[idx]){
            this.table[idx].push({key, value});
        } else {
            this.table[idx] = [{key, value}];
        }
        
    }

    getElement(key){
        const idx = hashFunc(key, this.table.length);

        if(!this.table[idx]){
            return null;
        }

        return this.table[idx].find(x => x.key === key).value;
    }
}

const hashT = new HashTable2();
hashT.setElement('one', 1);
hashT.setElement('two', 2);
hashT.setElement('three', 3);
hashT.setElement('tfour', 4);
console.log(hashT.table[0])
console.log(hashT.getElement('one'))
console.log(hashT.getElement('two'))
console.log(hashT.getElement('three'))
console.log(hashT.getElement('tfour'))
