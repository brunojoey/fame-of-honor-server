<template>
  <div :key="team.id" v-for="team in teams">
    <h2><a v-bind:href="'/teams/' + team.id">{{team.team_name}}</a></h2>
    <img :src="team.logo" :alt="team.logo" />
  </div>
</template>

<script>
 import DataService from "../services/DataService";

 export default {
   name: "teams",
   data() {
     return {
       teams: []
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
     }
   },
   mounted() {
     this.getTeams();
   }
 };
</script>