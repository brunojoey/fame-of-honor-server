<template>
<h1>Teams</h1>
<div class="team-page">
  <div :key="team.id" v-for="team in teams" class="team-card">
    <h3 class="team-name"><router-link :to="'/teams/' + team.id">{{team.team_name}}</router-link></h3>
    <img class="team-logo" :src="team.logo" :alt="team.logo" />
  </div>
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

<style>

.team-page {
  display: grid;
  grid-template-columns: repeat(3, 2fr);
  column-gap: 6rem;
  row-gap: 2rem;
}
  .team-card {
    text-align: center;
  }

  .team-name {
    font-weight: bold;
    transition: .2s all;
  }

    .team-name:hover {
      text-shadow: .2ch .2ch .5ch grey;
    }

  .team-logo {
    width: 75%;
  }

</style>
