<template>
  <h2>TEAM</h2>
</template>

<script>
import DataService from "../services/DataService";

export default {
  name: "teams",
  data() {
    return {
      team: {},
    };
  },
  methods: {
    getTeam(id) {
      DataService.getOneTeam(id)
        .then((response) => {
          this.team = response.data;
          console.log("Team", response.data);
        })
        .catch((e) => {
          console.log("error", e);
        });
    },
  },
  mounted() {
    this.getTeam();
  },
};
</script>

<style>
</style>