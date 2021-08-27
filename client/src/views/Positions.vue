  <template>
  <h1>Positions</h1>
  <div class="positions-page">
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/QB'">Quarterbacks</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/RB'">Running Backs</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/FB'">Full Backs</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/WR'">Wide Receivers</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/TE'">Tight Ends</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/OT'">Offensive Tackles</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/OG'">Offensive Guards</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/C'">Centers</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/DE'">Defensive Ends</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/DT'">Defensive Tackles</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/LB'">Linebackers</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/CB'">Cornerbacks</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/S'">Safties</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/K'">Kickers</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/P'">Punters</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/Coach'">Coaches</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/Coordinator'">Coordinators</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/Head%20Coach'">Head Coaches</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/General%20Manager'">General Managers</router-link>
    </li>
    <li class="position-item">
      <router-link class="position-link" :to="'/positions/Owner'">Owners</router-link>
    </li>
  </div>
</template>

<style>

h1 {
  text-align: center;
  text-decoration: underline;
  padding: 1rem 0;
}

  .positions-page {
    display: grid;
    grid-template-columns: repeat(4, 6fr);
    column-gap: 8rem;
    row-gap: 2rem;
    padding: 1rem 1rem 1rem 5rem;
  }

  .position-item {
    list-style: none;
    display: flex;
    justify-content: left;
    font-size: 150%;
    font-weight: bold;
  }

  .position-link {
    transition: .25s all;
  }

  .position-link:hover {
    text-decoration: line-through;
    text-shadow: .2ch .2ch .5ch grey;
    color: darkblue;
  }

</style>