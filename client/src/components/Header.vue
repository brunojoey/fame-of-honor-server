<template>
  <header class="navbar-header">
    <nav>
      <strong class="nav-item">Header</strong>
      <strong>
        <router-link class="nav-item link" :to="'/teams'">Teams</router-link>
      </strong>
      <strong>
        <router-link class="nav-item link" :to="'/positions'">Positions</router-link>
      </strong>
      <strong>
        <router-link class="nav-item link" :to="'/disclaimer'">Disclaimer</router-link>
      </strong>
    </nav>
  </header>
</template>

<style>
.navbar-header {
  padding: 1.5rem;
  background-color: rgb(231, 229, 229);
  display: flex;
  flex-direction: row;
}

.nav-item {
  padding: 2rem;
}

.link {
  text-decoration: none;

};
.link:hover {
  text-decoration: line-through;
}

</style>