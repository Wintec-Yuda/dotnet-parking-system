const wordsArr = ['cook', 'save', 'taste', 'aves', 'vase', 'state', 'map'];

const groupAnagrams = (wordList) => {
    const anagramMap = wordList.reduce((map, word) => {
        const sortedWord = word.split('').sort().join('');
        if (!map[sortedWord]) {
            map[sortedWord] = [];
        }
        map[sortedWord].push(word);
        return map;
    }, {});

    return Object.values(anagramMap);
};

console.log(groupAnagrams(wordsArr));
