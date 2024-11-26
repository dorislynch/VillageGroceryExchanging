
# react-native-village-grocery-exchanging

## Getting started

`$ npm install react-native-village-grocery-exchanging --save`

### Mostly automatic installation

`$ react-native link react-native-village-grocery-exchanging`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-village-grocery-exchanging` and add `RNVillageGroceryExchanging.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNVillageGroceryExchanging.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNVillageGroceryExchangingPackage;` to the imports at the top of the file
  - Add `new RNVillageGroceryExchangingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-village-grocery-exchanging'
  	project(':react-native-village-grocery-exchanging').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-village-grocery-exchanging/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-village-grocery-exchanging')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNVillageGroceryExchanging.sln` in `node_modules/react-native-village-grocery-exchanging/windows/RNVillageGroceryExchanging.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Village.Grocery.Exchanging.RNVillageGroceryExchanging;` to the usings at the top of the file
  - Add `new RNVillageGroceryExchangingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNVillageGroceryExchanging from 'react-native-village-grocery-exchanging';

// TODO: What to do with the module?
RNVillageGroceryExchanging;
```
  