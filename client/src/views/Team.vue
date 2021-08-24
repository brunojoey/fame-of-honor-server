<template>
  <h1 :key="team.id">{{team.team_name}}</h1>
  <img :src="team.logo" :alt="team.logo" />
  <div>
  <p><strong>Ring of Honor History: </strong> {{team.history}}</p>
    <h2>{{team.team_name}} Inductees</h2>
    <div :key="inductee.id" v-for="inductee in inductees" >
      <p><strong>Name: </strong>{{inductee.full_name}}</p>
      <p><strong>Position: </strong>{{inductee.player_position}}</p>
      <p v-if="inductee.notes"><strong>Additional Notes: </strong> {{inductee.notes}}</p>
      <p><strong>Years Active: </strong>{{inductee.years_active}}</p>
      <p><strong>Year Inducted: </strong>{{inductee.year_inducted}}</p>
      _________________________
    </div>
  </div>
</template>

<script>
import DataService from "../services/DataService";

export default {
  name: "team",
  data() {
    return {
      team: {},
      inductees: []
    };
  },
  methods: {
    async getTeam(id) {
      await DataService.getOneTeam(id)
        .then((response) => {
          this.team = response.data;
          console.log("Team", response.data);
        })
        .catch((err) => {
          console.log("error", err);
        });
    },
    async getTeamInductees(id) {
      await DataService.getTeamInductees(id) 
        .then((response) => {
          this.inductees = response.data;
          console.log("Inductees", response.data);
        })
        .catch((err) => {
          console.log("error", err)
        });
    }
  },
  mounted() {
    this.getTeam(this.$route.params.id);
    this.getTeamInductees(this.$route.params.id);
  },
};
</script>

<style>
</style>