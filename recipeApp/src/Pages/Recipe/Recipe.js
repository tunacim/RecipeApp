import React from "react";
import { View,FlatList, Text} from "react-native";
import RecipeCard from "../../Components/RecipeCard";
import UseFetch from "../../Hooks/UseFetch";
import styles from "./Recipe.style"


const Recipe=({route})=>{
   
     
        const url="http://localhost:5070/recipe/"
        const {id}=route.params
        const {data}=UseFetch("http://localhost:5070/recipe/"+id)
        if (!data) {
            return <Text>Loading...</Text>;
          }
        console.log(data)
        return(
            
                <View style={styles.container}>
            <View style={styles.innercontainer}>
            <Text style={styles.title}>{data.name}</Text>
            <Text style={styles.description}>{data.description}</Text>
            <View style={styles.line}></View>
            <Text style={styles.recipe}>{data.recipe}</Text>
            </View>
       
        </View>
                
         
               
            )
}

export default Recipe