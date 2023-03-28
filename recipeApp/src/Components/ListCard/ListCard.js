import React from "react";
import { View,Text } from "react-native";
import styles from "./ListCard.style"
function ListCard({item}){
    return(
        <View style={styles.container}>
            <Text style={styles.name}>{item.name}</Text>
            <Text style={styles.description}>{item.description}</Text>
        </View>
    )
}
export default ListCard