<template>
  <div id="app">
    <div class="title">
      <h1>{{getTitle}}</h1>
      <input type="text" v-model="textContext" />
      <button v-on:click="setText">Set New Text</button>
    </div>
    <div class="container">
      <Counter></Counter>
      <br />
      <div class="columns">
        <div class="column is-11">
          <AddCounter></AddCounter>
        </div>
        <div class="column auto">
          <RemoveCounter></RemoveCounter>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Counter from "./components/Counter.vue";
import AddCounter from "./components/AddCounter.vue";
import RemoveCounter from "./components/RemoveCounter.vue";
import { mapGetters, mapMutations } from "vuex";
export default {
  name: "app",
  data() {
    return {
      textContext: ""
    };
  },
  components: {
    Counter,
    AddCounter,
    RemoveCounter
  },
  methods: {
    setText(){
      this.$store.commit('changeTitle', this.textContext);
    }
  },
  computed: {
    ...mapGetters([
      "getTitle",
      ]),
  }
};
</script>

<style lang="scss">
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
