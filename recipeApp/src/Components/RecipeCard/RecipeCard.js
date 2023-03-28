import React from "react";
import {View,Text, } from "react-native";
import styles from "./RecipeCard.style"

const  RecipeCard=({recipe})=>{
    return(
        <View style={styles.container}>
            <View style={styles.innercontainer}>
            <Text style={styles.title}>{recipe.name}</Text>
            <Text style={styles.description}>{recipe.description}</Text>
            <View style={styles.line}></View>
            <Text style={styles.recipe}>{recipe.recipe}</Text>
            </View>
       
        </View>
        
    )
}
export default RecipeCard