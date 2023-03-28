import React from "react";
import { View,Text,TouchableOpacity} from "react-native";
import styles from "./ListCard.style"
function ListCard({item,onPress}){
    return(
        <TouchableOpacity onPress={onPress}>
        <View style={styles.container}>
            <Text style={styles.name}>{item.name}</Text>
            <Text style={styles.description}>{item.description}</Text>
        </View>
        </TouchableOpacity>
    )
}
export default ListCard