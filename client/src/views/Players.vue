<template>
<h1>Players</h1>
  <div :key="player.id" v-for="player in players">
    <h2><a :href="'/players/' + player.id">{{player.full_name}}</a></h2>
  </div>
</template>

<script>
 import DataService from "../services/DataService";

 export default {
   name: "players",
   data() {
     return {
       players: []
     }
   },
   methods: {
     getPlayers() {
       DataService.getAllPlayers()
        .then(response => {
          this.players = response.data;
          console.log("Players", response.data);
        })
        .catch(err => {
          console.log("error", err)
        });
     }
   },
   mounted() {
     this.getPlayers();
   }
 };
</script>