# odttf2ttf
odttf deobfuscator.
# Usage
### CMD
```cmd
odttf2ttf <odttfFilePath1> [odttfFilePath2] [odttfFilePath3]...
```
### JavaScript
Demo page: https://somanchiu.github.io/odttf2ttf/js/demo
```javascript
var odttf = new ODTTF();
odttf.deobfuscate(fontData, guid); //fontData:Uint8Array, guid:string
```
