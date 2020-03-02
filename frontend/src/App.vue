<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <v-app-bar-nav-icon @click="menu = !menu"></v-app-bar-nav-icon>

      <v-spacer></v-spacer>

      <v-btn href="https://github.com/vuetifyjs/vuetify/releases/latest" target="_blank" text>
        <span class="mr-2">Latest Release</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>
    <drower-menu :isShow="menu" v-if="menu" v-on:DrawerIsShow="menu = $event" />

    <v-content>
        <router-view></router-view>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import DrowerMenu from "./components/DrowerMenu.vue";

export default Vue.extend({
  name: "App",

  components: {
    DrowerMenu
  },

  data: () => ({
    menu: false
  })
});
</script>
