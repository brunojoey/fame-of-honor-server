import { createApp } from 'vue';
import App from './App.vue';
import router from "./router";
import "bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import loader from "vue-ui-preloader";

createApp(App).use(router).use(loader).mount('#app')
