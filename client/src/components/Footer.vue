<template>
  <footer class="navbar-footer">
    <nav>
      <strong class="nav-item">Footer</strong>
      <strong>
        <a class="nav-item link" :href="'https://www.nfl.com'">NFL</a>
      </strong>
      <strong>
        <a class="nav-item link" :href="'https://www.github.com/brunojoey'">Made by Joey Bruno</a>
      </strong>
    </nav>
  </footer>
</template>

<style>
.navbar-footer {
  position: relative;
  left: 0;
  bottom: 0;
  width: 100%;
  background-color: rgb(231, 229, 229);
  display: flex;
  flex-direction: row;
  padding: 1.5rem;
}

</style>