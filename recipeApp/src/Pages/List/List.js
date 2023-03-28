import React from "react";
import { SafeAreaView,View,FlatList} from "react-native";
import ListCard from "../../Components/ListCard";

const List=()=>{
    return(
       <View>
            <ListCard></ListCard>
           <FlatList data={null} renderItem={null}></FlatList>
        </View>
    )
}
export default List