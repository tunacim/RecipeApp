import React from "react";
import { View,Text } from "react-native";
import styles from "./ListCard.style"
function ListCard(){
    return(
        <View style={styles.container}>
            <Text style={styles.name}>RecipeName</Text>
            <Text style={styles.description}>RecipeDescription</Text>
        </View>
    )
}
export default ListCard