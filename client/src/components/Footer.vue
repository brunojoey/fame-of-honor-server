<template>
  <footer class="navbar-footer">
    <nav>
      <strong>
        <a class="nav-item link" :href="'https://www.nfl.com'">NFL</a>
      </strong>
      <strong>
        <a class="nav-item link" :href="'https://www.github.com/brunojoey'"
          >Made by Joey Bruno</a
        >
      </strong>
      <strong>
        <router-link class="nav-item link" :to="'/disclaimer'"
          >Disclaimer</router-link
        >
      </strong>
    </nav>
  </footer>
</template>

<style>
.navbar-footer {
  position: sticky;
  left: 0;
  bottom: 0;
  width: 100%;
  color: white;
  background-color: #2c3e50;
  padding: 1.5rem;
  height: 5rem;
}

.nav-item {
  color: white;
  transition: 0.2s all;
}

.nav-item:hover {
  -webkit-text-fill-color: white; /* Will override color (regardless of order) */
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: rgb(32, 87, 236);
  font-size: 1.45rem;
}

.nav-item:active {
  -webkit-text-fill-color: rgb(32, 87, 236); /* Will override color (regardless of order) */
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: white;
}
</style>