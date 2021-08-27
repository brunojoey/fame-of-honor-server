<template>
  <h1 :key="team.id">{{team.team_name}}</h1>
  <img :src="team.logo" :alt="team.logo" />
  <p><strong>Ring of Honor History: </strong> {{team.history}}</p>
    <h2>{{team.team_name}} Inductees</h2>
  <div class="inductee-page">
    <div :key="inductee.id" v-for="inductee in inductees" class="inductee-card" v-bind:style="{backgroundColor: team.color}">
      <p v-if="inductee.full_name"><strong>Name: </strong>{{inductee.full_name}}</p>
      <p v-if="inductee.player_position"><strong>Position: </strong>{{inductee.player_position}}</p>
      <p v-if="inductee.notes"><strong>Additional Notes: </strong> {{inductee.notes}}</p>
      <p v-if="inductee.years_active"><strong>Years Active: </strong>{{inductee.years_active}}</p>
      <p v-if="inductee.year_inducted"><strong>Year Inducted: </strong>{{inductee.year_inducted}}</p>
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
  .inductee-page {
    display: grid;
    grid-template-columns: repeat(4, 6fr);
    column-gap: 10rem;
    row-gap: 2rem;
    padding: 1rem 1rem 1rem 1rem;
  }

  .inductee-card {
    color: white;
    border-radius: .5rem;
    padding: 1rem;
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    align-items: left;
  }

</style>