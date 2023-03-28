import React from "react";
import {NavigationContainer}from "@react-navigation/native"
import {createNativeStackNavigator} from "@react-navigation/native-stack"

import List from "./Pages/List";
import Recipe from "./Pages/Recipe";

function Router(){
    const Stack=createNativeStackNavigator()
    return(
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name="List" component={List}></Stack.Screen>
                <Stack.Screen name="Recipe" component={Recipe}></Stack.Screen>
            </Stack.Navigator>
        </NavigationContainer>
    )
}
export default Router