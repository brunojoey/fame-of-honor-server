<template>
  <div :key="team.id" v-for="team in teams">
    <h2><router-link :to="'/teams/' + team.id">{{team.team_name}}</router-link></h2>
    <img :src="team.logo" :alt="team.logo" />
  </div>
</template>

<script>
 import DataService from "../services/DataService";
//  import Team from "./Team.vue";

 export default {
   name: "teams",
   data() {
     return {
       teams: [],
       currentTeam: {}
     }
   },
   methods: {
     getTeams() {
       DataService.getAllTeams()
        .then(response => {
          this.teams = response.data;
          console.log("Teams", response.data);
        })
        .catch(e => {
          console.log("error", e)
        });
     },
   },
   mounted() {
     this.getTeams();
   }
 };
</script>