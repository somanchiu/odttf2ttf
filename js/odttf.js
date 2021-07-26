function ODTTF(){
    this.deobfuscate = function (fontData, guid) {
        guid = guid.replace(/-/g, "");

        let key = [];
        const keyLength = 16;

        for (let i = 0; i < keyLength; i++)
            key[keyLength - 1 - i] = parseInt(guid.substr(i * 2, 2), 16);

        for (let i = 0; i < 32; i++)
            fontData[i] ^= key[i % key.length];
    };
}