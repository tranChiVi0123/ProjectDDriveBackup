<template>
  <div class="container">
    <div class="field is-grouped">
      <div class="control">
        <button class="button is-primary" v-on:click="removeCounter()">Remove</button>
      </div>
    </div>
  </div>
</template>

<script>
import { store } from "../store/store";
import * as types from "../types/mutactionTypes";
export default {
  methods: {
    removeCounter() {
      store.dispatch({
        type: types.Decrement,
        amount: 200
      });
    }
  }
};
</script>

<style>
</style>